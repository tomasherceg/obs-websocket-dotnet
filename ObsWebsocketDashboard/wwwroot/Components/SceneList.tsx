import * as React from "react";
import { Button } from "./Common/Button";

export interface SceneListProps {
    scenes: string[];
    activeScene: string;
    onSelect: (scene: string) => void;
}

export class SceneList extends React.Component<SceneListProps, {}> {
    render() {
        return this.props.scenes.map(s => <Button
                key={s}
                text={s}
                active={s === this.props.activeScene}
                isBlock={true}
                onClick={() => this.switchScene(s)} />);
        }

    switchScene(scene: string) {
        this.props.onSelect(scene);
    }
}