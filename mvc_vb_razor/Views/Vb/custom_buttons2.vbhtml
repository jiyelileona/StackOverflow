<!DOCTYPE html>
<html>
<head>
    <title>RichTextEditor - Custom buttons</title>
    <link rel="stylesheet" href="/Content/example.css" type="text/css" />
    <link type="text/css" href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.2/themes/smoothness/jquery-ui.css" rel="stylesheet" />
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.2/jquery-ui.min.js"></script>
</head>
<body>
    <script type="text/javascript">
        var editor;
        function RichTextEditor_OnLoad(rteeditor) {
            editor = rteeditor;
        }
        $(function () {
            $('#dialog').dialog({
                autoOpen: false,
                width: 350,
                buttons: {
                    "Ok": function () {
                        if (editor) {
                            editor.AppendHTML(document.getElementById("txt_input").value);
                            document.getElementById("txt_input").value = "";
                        }
                        $(this).dialog("close");
                    },
                    "Cancel": function () {
                        $(this).dialog("close");
                    }
                }
            });
        });
    </script>
    <script type="text/javascript">
        var loader;
        var editor;

        function RichTextEditor_OnCoreLoad(rteloader) {
            loader = rteloader;

            var config = loader._config;
            var toolbar = config._toolbartemplate || config.toolbar;

            var basetype = "image_" + config.skin + "_" + config.color;

            var dialog1 = "item_" + toolbar + "_" + config.skin + "_" + config.color + "_mydialog1";
            var define = jsml.class_define(dialog1, basetype);
            define.constructor(function () {
                this[basetype + "_constructor"]();
                this.set_imagename("openfolder");
                this.set_tooltip("My custom dialog!");
            });
            define.attach("click", function () {
                $('#dialog').dialog('open');
                return false;
            });

        }

        function RichTextEditor_OnLoad(rteeditor) {
            editor = rteeditor;
        }

    </script>
    <h1>
        Adding custom buttons (dialog)</h1>
    <p>
        The Rich Text Editor allows you extend the functions of the editor. You can create
        new custom buttons and add them to the editor's toolbar list.</p>
    <p>
        @Html.Raw(ViewBag.Editor)
    </p>
    <div id="dialog" title="RichTextEditor Custom Dialog" style="display: none;">
        <textarea id="txt_input" rows="4" style="width: 300px; height: 200px;"></textarea>
    </div>
</body>
</html>
