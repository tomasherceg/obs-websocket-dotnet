import { CaptionTemplate } from "../contracts";

import * as React from "react";

export interface CaptionsTemplateListProps {
    templates: CaptionTemplate[];
    onTemplateEdited: (template: CaptionTemplate) => void;
    onTemplateSelected: (template: CaptionTemplate) => void;
}

export class CaptionsTemplateList extends React.Component<CaptionsTemplateListProps, {}> {

    render() {
        return <table className="table table-striped">
            <thead>
                <tr>
                    <th>Type</th>
                    <th>Content</th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                {this.props.templates.map(t =>
                    <tr key={t.id}>
                        <td>{t.className}</td>
                        <td>{t.content}</td>
                        <td>
                            <button type="button"
                                className="btn btn-dark"
                                onClick={() => this.props.onTemplateEdited(t)}>
                                Customize
                            </button>
                        </td>
                        <td>
                            <button type="button"
                                    className="btn btn-primary"
                                    onClick={() => this.props.onTemplateSelected(t)}>
                                Display Now
                            </button>
                        </td>
                    </tr>)}
            </tbody>
        </table>;
    }
}