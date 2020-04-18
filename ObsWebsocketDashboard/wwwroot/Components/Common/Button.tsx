import * as React from "react";

export interface ButtonProps {
    text: string;
    active?: boolean;
    isBlock?: boolean;
    onClick: () => void;
}

export class Button extends React.Component<ButtonProps, {}> {
    render() {
        return (
            <input type="button"
                   value={this.props.text}
                   className={"btn" + (this.props.active ? " btn-primary" : " btn-secondary") + (this.props.isBlock ? " btn-block" : "")}
                   onClick={() => this.props.onClick()} />);
    }
}