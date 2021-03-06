<!DOCTYPE html>
<html>
<head>
    <title>RichTextEditor - Cleaning pasted content</title>
    <link rel="stylesheet" href="/Content/example.css" type="text/css" />
</head>
<body>
    @Code Html.BeginForm()End Code
    <h1>
        Cleaning pasted content</h1>
    <p>
        By default, RichTextEditor will automatically detect/clean the dirty pasted content.
        You have full control over how contributors paste content into the Editor. For example,
        you can disable the paste function, force pasting as plain text or prompt the user
        about cleaning up the content when pasting from MS Word.
    </p>
    <div>
        <div>
            <span id="MainContent_rbl_type">
                <input id="MainContent_rbl_type_0" type="radio" name="SelectType" value="" checked="checked"
                    onclick="MvcSubmit();" /><label for="MainContent_rbl_type_0">Default</label>
                <input id="MainContent_rbl_type_1" type="radio" name="SelectType" value="Disabled"
                    onclick="MvcSubmit();" /><label for="MainContent_rbl_type_1">Disabled</label>
                <input id="MainContent_rbl_type_2" type="radio" name="SelectType" value="Paste" onclick="MvcSubmit();" /><label
                    for="MainContent_rbl_type_2">Paste</label>
                <input id="MainContent_rbl_type_3" type="radio" name="SelectType" value="PasteText"
                    onclick="MvcSubmit();" /><label for="MainContent_rbl_type_3">PasteText</label>
                <input id="MainContent_rbl_type_4" type="radio" name="SelectType" value="PasteWord"
                    onclick="MvcSubmit();" /><label for="MainContent_rbl_type_4">PasteWord</label>
                <input id="MainContent_rbl_type_5" type="radio" name="SelectType" value="ConfirmWord"
                    onclick="MvcSubmit();" /><label for="MainContent_rbl_type_5">ConfirmWord</label>
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
    @Code Html.EndForm()End Code
</body>
</html>
