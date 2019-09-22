'use strict';

class ControlPanel extends React.Component {

    constructor(props) {
        super(props);
        this.state = { isConnected: false };
    }

    render() {
        if (this.state.isConnected) {
            return (<div>
                <div className="toolbar">
                    <Button text="Recording" active={this.state.isRecording} onClick={() => this.props.app.changeRecordingState(!this.state.isRecording)} />
                    <Button text="Streaming" active={this.state.isStreaming} onClick={() => this.props.app.changeStreamingState(!this.state.isStreaming)} />
                </div>
                <div className="scene-list">
                    <SceneList scenes={this.state.scenes} activeScene={this.state.activeScene} onSelect={scene => this.props.app.switchScene(scene)} />
                </div>
            </div>);
        } else {
            return <div>Waiting for client data...</div>;
        }
    }
}

class Button extends React.Component {
    render() {
        return (
            <input type="button"
                value={this.props.text}
                className={"btn" + (this.props.active ? " btn-primary" : " btn-secondary") + (this.props.isBlock ? " btn-block" : "")}
                onClick={() => this.props.onClick()} />);
    }
}

class SceneList extends React.Component {
    render() {
        return this.props.scenes.map(s => <Button key={s} text={s} active={s === this.props.activeScene} isBlock={true} onClick={() => this.switchScene(s)} />);
    }

    switchScene(scene) {
        this.props.onSelect(scene);
    }
}

class App {
    constructor(signalR, clientId) {
        this.clientId = clientId;
    }

    run() {
        let domContainer = document.querySelector('#container');
        let root = ReactDOM.render(<ControlPanel app={this} />, domContainer);

        this.connection = new signalR.HubConnectionBuilder()
            .withUrl("/obs")
            .configureLogging(signalR.LogLevel.Information)
            .build();

        this.connection.on("StatusChanged",
            (remoteClientId, status) => {
                if (remoteClientId === this.clientId) {
                    root.setState(status);
                }
            });
        this.connection.on("ChangeRecordingState", () => { });
        this.connection.on("ChangeStreamingState", () => { });
        this.connection.on("SwitchScene", () => { });

        let connect = () => {
            this.connection.start().then(
                () => { this.connection.invoke("GetLastStatus", this.clientId); },
                err => {
                    root.setState({ isConnected: false });
                    console.log(err);
                    setTimeout(() => connect(), 5000);
                });
        };
        this.connection.onclose(() => {
            root.setState({ isConnected: false });
            connect();
        });
        connect();
    }

    switchScene(scene) {
        this.connection.invoke("SwitchScene", this.clientId, scene);
    }

    changeRecordingState(enabled) {
        this.connection.invoke("ChangeRecordingState", this.clientId, enabled);
    }

    changeStreamingState(enabled) {
        this.connection.invoke("ChangeStreamingState", this.clientId, enabled);
    }
}
