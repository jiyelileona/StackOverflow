<!DOCTYPE html>
<html>
<head>
    <title>Rich Text Editor: Setting the max length</title>
    <link rel="stylesheet" href="/Content/example.css" type="text/css" />
</head>
<body>
    @Code Html.BeginForm()End Code
    <h1>
        Use MaxHTMLLength or MaxTextLength to Protect Your Database</h1>
    <p>
        We often use a database backend such as <a target="_blank" href="http://www.microsoft.com/sql/">
            SQL Server</a> to store data. In such databases, you have to specify the length
        of any textual field when a table is designed. If you tried to insert a record whose
        text length is greater than allowed by your table, an error will be reported.
        <br />
        <br />
        To prevent this type of error from occurring, developers can use <strong>MaxHTMLLength</strong>
        or <strong>MaxTextLength</strong> in the RichTextEditor to limit the length of the
        user's input.
    </p>
    <div>
        <div>
            <span id="MainContent_rbl_type">
                <input id="MainContent_rbl_type_0" type="radio" name="SelectType" value="" checked="checked"
                    onclick="MvcSubmit();" /><label for="MainContent_rbl_type_0">Non-limit</label>
                <input id="MainContent_rbl_type_1" type="radio" name="SelectType" value="html" onclick="MvcSubmit();" /><label
                    for="MainContent_rbl_type_1">MaxHTMLLength : 100</label>
                <input id="MainContent_rbl_type_2" type="radio" name="SelectType" value="text" onclick="MvcSubmit();" /><label
                    for="MainContent_rbl_type_2">MaxTextLength : 100</label></span>
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
