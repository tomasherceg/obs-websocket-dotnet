﻿import { ControlPanelState, CaptionTemplate } from "./contracts";

import * as React from "react";
import * as ReactDOM from "react-dom";
import * as signalR from "@microsoft/signalr";

import { ControlPanel } from "./Components/ControlPanel";
import { CaptionsPanel } from "./Components/CaptionsPanel";

export interface AppProps {
    clientId: string;
}

export class App extends React.Component<AppProps, ControlPanelState> {

    private connection: signalR.HubConnection;

    constructor(props: AppProps) {
        super(props);
        this.state = { isConnected: false };

        this.connection = new signalR.HubConnectionBuilder()
            .withUrl("/obs", { accessTokenFactory: () => this.props.clientId })
            .withAutomaticReconnect()
            .configureLogging(signalR.LogLevel.Information)
            .build();
    
        this.connection.on("StatusChanged", (status: ControlPanelState) => {
            this.setState(status);
        });
        this.connection.on("ChangeRecordingState", () => { });
        this.connection.on("ChangeStreamingState", () => { });
        this.connection.on("SwitchScene", () => { });

        this.connection.onclose(() => {
            this.setState({ isConnected: false });
            console.log("Connection closed.");
        });
        this.connection.onreconnecting(() => {
            this.setState({ isConnected: false });
            console.log("Reconnecting...");
        });
        this.connection.onreconnected(() => {
            console.log("Reconnected...");
        });

        this.connect();
    }

    async connect() {
        try {
            await this.connection.start();
            await this.connection.invoke("GetLastStatus");
        }
        catch (err) {
            this.setState({ isConnected: false });
            console.log(err);
            setTimeout(() => this.connect(), 5000);
        }
    }

    switchScene(scene: string) {
        this.connection.invoke("SwitchScene", scene);
    }

    changeRecordingState(enabled: boolean) {
        this.connection.invoke("ChangeRecordingState", enabled);
    }

    changeStreamingState(enabled: boolean) {
        this.connection.invoke("ChangeStreamingState", enabled);
    }

    render() {
        return (
            <div>
                <div className="row">
                    <div className="col-lg-6">
                        <ControlPanel
                            state={this.state}
                            onSwitchScene={this.switchScene.bind(this)}
                            onChangeRecordingState={this.changeRecordingState.bind(this)}
                            onChangeStreamingState={this.changeStreamingState.bind(this)} />
                    </div>
                    <div className="col-lg-6">
                        <CaptionsPanel 
                            templates={this.getDefaultTemplates()}
                            onCaptionQueued={this.captionQueued.bind(this)}/>
                    </div>
                </div>
            </div>);
    }

    getDefaultTemplates(): CaptionTemplate[] {
        return [
            { id: "1", className: "speaker-name", content: "Tomáš Herceg" },
            { id: "2", className: "speaker-name", content: "Roman Jašek" },
            { id: "3", className: "speaker-name", content: "Michal Tichý" },
            { id: "4", className: "speaker-name", content: "Milan Mikuš" },
            { id: "5", className: "notification", content: "Get DotVVM for Visual Studio --- <u>https://www.dotvvm.com/install</u>" },
            { id: "6", className: "notification", content: "DotVVM Documentation --- <u>https://www.dotvvm.com/docs</u>" },
            { id: "7", className: "notification", content: "Cheat Sheet for Web Forms devs --- <u>https://www.dotvvm.com/webforms</u>" },
            { id: "8", className: "notification", content: "Ask us anything in the chat ➡➡" }
        ];
    }

    captionQueued(caption: CaptionTemplate) {
        this.connection.invoke("QueueCaption", caption.className, caption.content);
    }
}

const container = document.getElementById("container");
if (container) {
    const clientId = container.dataset["clientid"] as string;
    ReactDOM.render(<App clientId={clientId} />, container);
}