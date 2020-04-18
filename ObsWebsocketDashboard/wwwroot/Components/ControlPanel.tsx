import { ControlPanelState } from "../contracts";

import * as React from "react";

import { Button } from "./Common/Button";
import { SceneList } from "./SceneList";

export interface ControlPanelProps {
    onChangeRecordingState: (enabled: boolean) => void;
    onChangeStreamingState: (enabled: boolean) => void;
    onSwitchScene: (scene: string) => void;
    state: ControlPanelState;
}

export class ControlPanel extends React.Component<ControlPanelProps, { }> {

    constructor(props: ControlPanelProps) {
        super(props);
    }

    render() {
        const state = this.props.state;
        if (state.isConnected) {
            return (<div>
                        <h2>Scene Control</h2>
                        <div className="toolbar">
                            <Button text="Recording" active={state.isRecording}
                                onClick={() => this.props.onChangeRecordingState(state.isConnected && !state.isRecording)} />
                            <Button text="Streaming" active={state.isStreaming}
                                onClick={() => this.props.onChangeStreamingState(state.isConnected && !state.isStreaming)} />
                        </div>
                        <div className="scene-list">
                            <SceneList scenes={state.scenes} activeScene={state.activeScene}
                                onSelect={scene => this.props.onSwitchScene(scene)} />
                        </div>
                    </div>);
        } else {
            return <div>Waiting for client data...</div>;
        }
    }
}