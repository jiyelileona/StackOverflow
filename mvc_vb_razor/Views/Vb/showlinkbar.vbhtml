<!DOCTYPE html>
<html>
<head>
    <title>RichTextEditor - Show or hide link editing box</title>
    <link rel="stylesheet" href="/Content/example.css" type="text/css" />
</head>
<body>
    @Code Html.BeginForm()End Code
    <h1>
        Show or hide link editing box</h1>
    <p>
        When a hyperlink is selected, a link editing box will be displayed in the editor.
        You can turn it off by setting this property to "false".
    </p>
    <div>
        <div>
            <span id="MainContent_rbl_type">
                <input id="MainContent_rbl_type_0" type="radio" name="SelectType" value="" checked="checked"
                    onclick="MvcSubmit();" /><label for="MainContent_rbl_type_0">Default</label>
                <input id="MainContent_rbl_type_1" type="radio" name="SelectType" value="yes" onclick="MvcSubmit();" /><label
                    for="MainContent_rbl_type_1">Show Linkbar</label>
                <input id="MainContent_rbl_type_2" type="radio" name="SelectType" value="no" onclick="MvcSubmit();" /><label
                    for="MainContent_rbl_type_2">Hide Linkbar</label></span>
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
    @Code Html.EndForm()End Code
</body>
</html>
