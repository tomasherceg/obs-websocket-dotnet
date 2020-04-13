'use strict';

var _createClass = (function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; })();

var _get = function get(_x, _x2, _x3) { var _again = true; _function: while (_again) { var object = _x, property = _x2, receiver = _x3; _again = false; if (object === null) object = Function.prototype; var desc = Object.getOwnPropertyDescriptor(object, property); if (desc === undefined) { var parent = Object.getPrototypeOf(object); if (parent === null) { return undefined; } else { _x = parent; _x2 = property; _x3 = receiver; _again = true; desc = parent = undefined; continue _function; } } else if ("value" in desc) { return desc.value; } else { var getter = desc.get; if (getter === undefined) { return undefined; } return getter.call(receiver); } } };

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _inherits(subClass, superClass) { if (typeof superClass !== "function" && superClass !== null) { throw new TypeError("Super expression must either be null or a function, not " + typeof superClass); } subClass.prototype = Object.create(superClass && superClass.prototype, { constructor: { value: subClass, enumerable: false, writable: true, configurable: true } }); if (superClass) Object.setPrototypeOf ? Object.setPrototypeOf(subClass, superClass) : subClass.__proto__ = superClass; }

var ControlPanel = (function (_React$Component) {
    _inherits(ControlPanel, _React$Component);

    function ControlPanel(props) {
        _classCallCheck(this, ControlPanel);

        _get(Object.getPrototypeOf(ControlPanel.prototype), "constructor", this).call(this, props);
        this.state = { isConnected: false };
    }

    _createClass(ControlPanel, [{
        key: "render",
        value: function render() {
            var _this = this;

            if (this.state.isConnected) {
                return React.createElement(
                    "div",
                    null,
                    React.createElement(
                        "div",
                        { className: "toolbar" },
                        React.createElement(Button, { text: "Recording", active: this.state.isRecording, onClick: function () {
                                return _this.props.app.changeRecordingState(!_this.state.isRecording);
                            } }),
                        React.createElement(Button, { text: "Streaming", active: this.state.isStreaming, onClick: function () {
                                return _this.props.app.changeStreamingState(!_this.state.isStreaming);
                            } })
                    ),
                    React.createElement(
                        "div",
                        { className: "scene-list" },
                        React.createElement(SceneList, { scenes: this.state.scenes, activeScene: this.state.activeScene, onSelect: function (scene) {
                                return _this.props.app.switchScene(scene);
                            } })
                    )
                );
            } else {
                return React.createElement(
                    "div",
                    null,
                    "Waiting for client data..."
                );
            }
        }
    }]);

    return ControlPanel;
})(React.Component);

var Button = (function (_React$Component2) {
    _inherits(Button, _React$Component2);

    function Button() {
        _classCallCheck(this, Button);

        _get(Object.getPrototypeOf(Button.prototype), "constructor", this).apply(this, arguments);
    }

    _createClass(Button, [{
        key: "render",
        value: function render() {
            var _this2 = this;

            return React.createElement("input", { type: "button",
                value: this.props.text,
                className: "btn" + (this.props.active ? " btn-primary" : " btn-secondary") + (this.props.isBlock ? " btn-block" : ""),
                onClick: function () {
                    return _this2.props.onClick();
                } });
        }
    }]);

    return Button;
})(React.Component);

var SceneList = (function (_React$Component3) {
    _inherits(SceneList, _React$Component3);

    function SceneList() {
        _classCallCheck(this, SceneList);

        _get(Object.getPrototypeOf(SceneList.prototype), "constructor", this).apply(this, arguments);
    }

    _createClass(SceneList, [{
        key: "render",
        value: function render() {
            var _this3 = this;

            return this.props.scenes.map(function (s) {
                return React.createElement(Button, { key: s, text: s, active: s === _this3.props.activeScene, isBlock: true, onClick: function () {
                        return _this3.switchScene(s);
                    } });
            });
        }
    }, {
        key: "switchScene",
        value: function switchScene(scene) {
            this.props.onSelect(scene);
        }
    }]);

    return SceneList;
})(React.Component);

var App = (function () {
    function App(signalR, clientId) {
        _classCallCheck(this, App);

        this.clientId = clientId;
    }

    _createClass(App, [{
        key: "run",
        value: function run() {
            var _this4 = this;

            var domContainer = document.querySelector('#container');
            var root = ReactDOM.render(React.createElement(ControlPanel, { app: this }), domContainer);

            this.connection = new signalR.HubConnectionBuilder().withUrl("/obs", { accessTokenFactory: function accessTokenFactory() {
                    return _this4.clientId;
                } }).withAutomaticReconnect().configureLogging(signalR.LogLevel.Information).build();

            this.connection.on("StatusChanged", function (status) {
                root.setState(status);
            });
            this.connection.on("ChangeRecordingState", function () {});
            this.connection.on("ChangeStreamingState", function () {});
            this.connection.on("SwitchScene", function () {});

            this.connection.onclose(function () {
                root.setState({ isConnected: false });
                console.log("Connection closed.");
            });
            this.connection.onreconnecting(function () {
                root.setState({ isConnected: false });
                console.log("Reconnecting...");
            });
            this.connection.onreconnected(function () {
                console.log("Reconnected...");
            });

            this.connect();
        }
    }, {
        key: "connect",
        value: function connect() {
            var _this5 = this;

            this.connection.start().then(function () {
                _this5.connection.invoke("GetLastStatus");
            }, function (err) {
                root.setState({ isConnected: false });
                console.log(err);
                setTimeout(function () {
                    return _this5.connect();
                }, 5000);
            });
        }
    }, {
        key: "switchScene",
        value: function switchScene(scene) {
            this.connection.invoke("SwitchScene", scene);
        }
    }, {
        key: "changeRecordingState",
        value: function changeRecordingState(enabled) {
            this.connection.invoke("ChangeRecordingState", enabled);
        }
    }, {
        key: "changeStreamingState",
        value: function changeStreamingState(enabled) {
            this.connection.invoke("ChangeStreamingState", enabled);
        }
    }]);

    return App;
})();

