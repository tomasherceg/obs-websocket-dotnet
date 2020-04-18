export type ControlPanelState =
    {
         isConnected: false;
    } |
    {
        isConnected: true;
        isRecording: boolean;
        isStreaming: boolean;
        activeScene: string;
        scenes: string[];
    }

export type CaptionTemplate = {
    id?: string;
    className: string;
    content: string;
}