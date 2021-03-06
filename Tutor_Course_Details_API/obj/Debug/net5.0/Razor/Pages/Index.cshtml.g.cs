#pragma checksum "C:\Users\atind\Downloads\Tutor_Course_Details_API\Tutor_Course_Details_API\Tutor_Course_Details_API\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4675b8525f3a2316f7f19fa644e151d61741fb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4675b8525f3a2316f7f19fa644e151d61741fb7", @"/Pages/Index.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4675b8525f3a2316f7f19fa644e151d61741fb72758", async() => {
                WriteLiteral(@"
    <title>Tutor Deparment Details</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4675b8525f3a2316f7f19fa644e151d61741fb73987", async() => {
                WriteLiteral(@"
    <div>
        <!-- Navigation bar with Insert details button-->
        <nav class=""navbar navbar-expand-lg navbar-light bg-secondary"">
            <a class=""navbar-brand"" href=""#"">Tutor Department Details</a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarText"" aria-controls=""navbarText"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarText"">
                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item active"">
                        <button class=""btn btn-success"" data-toggle=""modal"" data-target=""#insertDetails"">Insert Tutor Details</button>
                    </li>
                </ul>
            </div>
        </nav>
        <br/>
        <!-- Main Area where data will display-->
        <div class=""container"" >
            <div class=""row"" id=""TutorDetailsSection""></div>

  ");
                WriteLiteral(@"      </div>
    </div>
    <!-- web form to insert the data-->
    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""insertDetails"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Insert New Record</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <form>
                        <div class=""form-group"">
                            <label for=""TutorName"">Tutor Name</label>
                            <input type=""text"" class=""form-control"" id=""Tutor_name"" aria-describedby=""Tutor_nameHelp"">
                        </div>
                        <div class=""form-group"">
                            <label for=""DepartmentName"">Department Name</label>
        ");
                WriteLiteral(@"                    <input type=""text"" class=""form-control"" id=""Department_name"" aria-describedby=""Department_nameHelp"">
                        </div>
                        <div class=""form-group"">
                            <label for=""CourseName"">Course Name</label>
                            <input type=""text"" class=""form-control"" id=""Course_Name"" aria-describedby=""Course_NameHelp"">
                        </div>
                        <div class=""form-group"" id=""result"">
                        </div>
                        <button type=""button"" onclick=""insert()"" class=""btn btn-danger"">Insert</button>
                    </form>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                </div>
            </div>
        </div>
    </div>
    <!-- web form to update the data-->
    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""UpdateDetails"">
        <div class=""modal");
                WriteLiteral(@"-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Update Record</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <form>
                        <div class=""form-group"">
                            <input type=""hidden"" class=""form-control"" id=""Edit_id"" aria-describedby=""Id_Help"">
                        </div>
                        <div class=""form-group"">
                            <label for=""TutorName"">Tutor Name</label>
                            <input type=""text"" class=""form-control"" id=""Edit_Tutor_name"" aria-describedby=""Tutor_nameHelp"">
                        </div>
                        <div class=""form-group"">
                            <label for=""DepartmentName"">");
                WriteLiteral(@"Department Name</label>
                            <input type=""text"" class=""form-control"" id=""Edit_Department_name"" aria-describedby=""Department_nameHelp"">
                        </div>
                        <div class=""form-group"">
                            <label for=""CourseName"">Course Name</label>
                            <input type=""text"" class=""form-control"" id=""Edit_Course_Name"" aria-describedby=""Course_NameHelp"">
                        </div>
                        <div class=""form-group"" id=""resultUpdate"">
                        </div>
                        <button type=""button"" onclick=""Update()"" class=""btn btn-danger"">Modify</button>
                    </form>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-dark"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>
    <!-- JavaScript Files-->
    <script src=""https://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.");
                WriteLiteral(@"0.3.min.js""></script>
    <script src=""https://ajax.aspnetcdn.com/ajax/jquery.templates/beta1/jquery.tmpl.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>

    <script>
        var uri = 'api/TutorDetails';
        $(document).ready(function () {
            // Gets all data
            $.getJSON(uri).done(function (data) {
                $(""#Main_temp"").tmpl(data).appendTo(""#TutorDetailsSection"");
            });
        });
        function TutorData() {
            $.getJSON(uri).done(function (data) {
                $(""#TutorDetailsSection"").text("""");
                $(""#Main_temp"").tmpl(data).appendTo(""#TutorDetailsSection"");
 ");
                WriteLiteral(@"           });
        }
        //function to Insert Data
        function insert() {
            var _Tutor_name = $('#Tutor_name').val();
            var _Department_name = $('#Department_name').val();
            var _Course_Name = $('#Course_Name').val();

            var TutorData_Object = {
                tutorName: _Tutor_name,
                departmentName: _Department_name,
                courseName: _Course_Name
            };
            $.ajax({
                type: ""POST"",
                url: uri,
                data: JSON.stringify(TutorData_Object),
                contentType: ""application/json; charset=utf-8""
            }).done(function (response) {
                $(""#result"").html(""Record inserted successfully"");
                TutorData();
            }).fail(function (jqXHR, textStatus) {
                $(""#result"").html(""Record is not inserted. There is an error"");
            });
        }
        //function to Update Data
        function Update() {
            var _Tutor_nam");
                WriteLiteral(@"e = $('#Edit_Tutor_name').val();
            var _Department_name = $('#Edit_Department_name').val();
            var _Course_Name = $('#Edit_Course_Name').val();

            var TutorUpdateData_Obj = {
                id: parseInt($('#Edit_id').val()),
                tutorName: _Tutor_name,
                departmentName: _Department_name,
                courseName: _Course_Name
            };
            $.ajax({
                type: ""PUT"",
                url: uri + ""/"" + $('#Edit_id').val(),
                data: JSON.stringify(TutorUpdateData_Obj),
                contentType: ""application/json; charset=utf-8""
            }).done(function (response) {
                $(""#resultUpdate"").html(""Record updated successfully"");
                TutorData();
            }).fail(function (jqXHR, textStatus) {
                $(""#resultUpdate"").html(""Record is not inserted. There is an error"");
            });
        }
        // function to remove record
        function remove(id) {
            var yes = co");
                WriteLiteral(@"nfirm(""Do you really want to delete this account?"");
            if (yes) {
                $.ajax({
                    type: ""DELETE"",
                    url: uri + ""/"" + id,
                }).done(function (response) {
                    TutorData();
                });
            }
        }
        //function to display data in update form
        function UpdateRecord(id) {
            $.ajax({
                type: ""GET"",
                url: uri + ""/"" + id,
                contentType: ""application/json""
            }).done(function (response) {
                $('#Edit_id').val(response.id);
                $('#Edit_Tutor_name').val(response.tutorName);
                $('#Edit_Department_name').val(response.departmentName);
                $('#Edit_Course_Name').val(response.courseName);
            });
        }
    </script>
    <!--Template to display data-->
    <script id=""Main_temp"" type=""text/x-jquery-tmpl"">
        <div class=""col-lg-4"">
            <div class=""card border-secondary mb-3");
                WriteLiteral(@""">
                <img src="""" class=""card-img-top"" alt="""">
                <div class=""card-body"">
                    <h5 class=""card-title"">Tutor Name: ${tutorName}</h5>
                    <p class=""card-text"">Department Name: ${departmentName}</p>
                    <p class=""card-text"">Course Name: ${courseName}</p>
                    <button class=""btn btn-outline-danger"" onclick=""UpdateRecord('${id}')"" data-toggle=""modal"" data-target=""#UpdateDetails"">Update</button>
                    <a href=""#"" class=""btn btn-outline-dark"" onclick=""remove('${id}')"">Delete</a>
                </div>
            </div>
        </div>
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index>)PageContext?.ViewData;
        public Pages_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
