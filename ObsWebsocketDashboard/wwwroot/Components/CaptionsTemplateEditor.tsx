import { CaptionTemplate } from "../contracts";

import * as React from "react";

export interface CaptionsTemplateEditorProps {
    template: CaptionTemplate;
    onConfirm: (template: CaptionTemplate) => void;
    onCancel: () => void;
}

export class CaptionsTemplateEditor extends React.Component<CaptionsTemplateEditorProps, {}> {

    private classNameRef: React.RefObject<HTMLSelectElement>;
    private contentRef: React.RefObject<HTMLTextAreaElement>;

    constructor(props: CaptionsTemplateEditorProps) {
        super(props);

        this.classNameRef = React.createRef<HTMLSelectElement>();
        this.contentRef = React.createRef<HTMLTextAreaElement>();
    }

    render() {
        if (this.props.template) {
            return <form onSubmit={this.onConfirm.bind(this)}>
                <div className="form-group">
                    <label>Type</label>
                    <select ref={this.classNameRef} className="form-control" defaultValue={this.props.template.className}>
                        <option value="speaker-name">Speaker Name</option>
                        <option value="notification">Notification</option>
                    </select>
                </div>
                <div className="form-group">
                    <label>Content</label>
                    <textarea ref={this.contentRef} className="form-control" defaultValue={this.props.template.content}></textarea>
                </div>
                <div className="form-group">
                    <button type="submit" className="btn btn-primary">Queue Caption</button>
                    <button type="button" className="btn btn-danger" onClick={() => this.props.onCancel()}>Cancel</button>
                </div>
            </form>;
        } else {
            return <div></div>;
        }
    }

    onConfirm(event) {
        event.preventDefault();

        const template = {
            className: this.classNameRef.current.value,
            content: this.contentRef.current.value
        };
        this.props.onConfirm(template);
    }
}