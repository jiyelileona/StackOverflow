<!DOCTYPE html>
<html>
<head>
    <title>RichTextEditor - Formatting bold button</title>
    <link rel="stylesheet" href="/Content/example.css" type="text/css" />
</head>
<body>
    <script type="text/javascript">
        var editor;
        function RichTextEditor_OnLoad(rteeditor) {
            editor = rteeditor;
            editor.AttachEvent("TextChanged", ShowHtml);
        }
        function ShowHtml() {
            if (!editor) return;
            var c = editor.GetText();
            if (!c) {
                document.getElementById("result").innerHTML = "";
                return;
            }
            document.getElementById("result").innerHTML = c.replace(/</g, "&lt;");
        }
    </script>
    @Code Html.BeginForm()End Code
    <h1>
        Formatting bold button</h1>
    <p>
        RichTextEditor enables you to override and define you own custom format tags. By
        default, when you use the Bold button on the toolbar, RichTextEditor inserts a set
        of &lt;strong&gt;tags to format the selected text. The &lt;strong&gt; tags are the
        current standard for marking text as bold. If you prefer to use the &lt;b&gt;tags
        or CSS "font-weight" property instead, you can change the editor configuration to
        change the behavior of bold button.
    </p>
    <div>
        <div>
            <span id="MainContent_rbl_type">
                <input id="MainContent_rbl_type_0" type="radio" name="SelectType" value="" checked="checked"
                    onclick="MvcSubmit();" /><label for="MainContent_rbl_type_0">Default: &lt;strong&gt;</label>
                <input id="MainContent_rbl_type_1" type="radio" name="SelectType" value="b" onclick="MvcSubmit();" /><label
                    for="MainContent_rbl_type_1">&lt;b&gt;</label>
                <input id="MainContent_rbl_type_2" type="radio" name="SelectType" value="span" onclick="MvcSubmit();" /><label
                    for="MainContent_rbl_type_2">&lt;span style='font-weight:bold'&gt;</label>
            </span>
            <script type="text/javascript">
                var ipts = document.getElementsByName("SelectType");
                var mode = '@ViewBag._mode' || "";
                if (mode) {
                    for (var i = 0; i < ipts.length; i++) {
                        if (ipts[i].value == mode) {
                            ipts[i].checked = true;
                            break;
                        }
                    }
                }
                function MvcSubmit() {
                    document.getElementById('btn_sumbit').click();
                }
            </script>
            <button id="btn_sumbit" style="display: none;" type="submit">
                Submit</button>
        </div>
        <br />
        @Html.Raw(ViewBag.Editor)
    </div>
    <div>
        <h3>
            Result html code:</h3>
        <div id="result">
        </div>
    </div>
    @Code Html.EndForm()End Code
</body>
</html>
