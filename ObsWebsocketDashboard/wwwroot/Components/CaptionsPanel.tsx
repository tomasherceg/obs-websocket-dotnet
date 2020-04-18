import { CaptionTemplate } from "../contracts";

import * as React from "react";

import { CaptionsTemplateList } from "./CaptionsTemplateList";
import { CaptionsTemplateEditor } from "./CaptionsTemplateEditor";

export interface CaptionsPanelProps {
    templates: CaptionTemplate[];
    onCaptionQueued: (caption: CaptionTemplate) => void;
}

export interface CaptionsPanelState {
    editedTemplate: CaptionTemplate | null;
}

export class CaptionsPanel extends React.Component<CaptionsPanelProps, CaptionsPanelState> {

    constructor(props: CaptionsPanelProps) {
        super(props);
        this.state = {
            editedTemplate: null
        };
    }

    render() {
        return <div>
            <h2>Live Captions</h2>
            <p><small>URL for Browser in OBS: <code>/captions?access_token=...&amp;theme=update</code></small></p>
            <CaptionsTemplateList templates={this.props.templates}
                onTemplateEdited={this.useTemplate.bind(this)}
                onTemplateSelected={this.captionCreated.bind(this)}/>
            <CaptionsTemplateEditor template={this.state.editedTemplate}
                onConfirm={this.captionCreated.bind(this)}
                onCancel={this.resetTemplate.bind(this)} />
        </div>;
    }

    useTemplate(template: CaptionTemplate) {
        this.setState({
            editedTemplate: {
                className: template.className,
                content: template.content
            }
        });
    }

    resetTemplate() {
        this.setState({
            editedTemplate: null
        });
    }

    captionCreated(caption: CaptionTemplate) {
        this.props.onCaptionQueued(caption);
        this.resetTemplate();
    }

}