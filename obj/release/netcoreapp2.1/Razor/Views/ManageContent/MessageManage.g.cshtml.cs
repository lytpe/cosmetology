#pragma checksum "D:\Cosmetology\Views\ManageContent\MessageManage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1b3d091896c44f7657b1fc3bbfc1e695751450d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageContent_MessageManage), @"mvc.1.0.view", @"/Views/ManageContent/MessageManage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ManageContent/MessageManage.cshtml", typeof(AspNetCore.Views_ManageContent_MessageManage))]
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
#line 1 "D:\Cosmetology\Views\_ViewImports.cshtml"
using Cosmetology;

#line default
#line hidden
#line 2 "D:\Cosmetology\Views\_ViewImports.cshtml"
using Cosmetology.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1b3d091896c44f7657b1fc3bbfc1e695751450d", @"/Views/ManageContent/MessageManage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b18df4fa33464af10ca5f6ee8eccd6c0cd551511", @"/Views/_ViewImports.cshtml")]
    public class Views_ManageContent_MessageManage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Cosmetology\Views\ManageContent\MessageManage.cshtml"
  
  Layout="/Views/ManageContent/_Layout.cshtml";
  ViewData["Title"]="访客消息";

#line default
#line hidden
            BeginContext(85, 3123, true);
            WriteLiteral(@" <div class=""container"">
        <div class=""col-sm-1 col-md-1 col-lg-1""></div>
         <div class=""col-sm-10 col-md-10 col-lg-10"">
             <div id=""toolbar"">
                <button id=""delete"" class=""btn btn-danger"">删除</button>
             </div>
             <table id=""listtable""></table>
         </div>
         <div class=""col-sm-1 col-md-1 col-lg-1""></div>
    </div>
<script>
         $table=$(""#listtable"");
		 $table.bootstrapTable({
            url: '/ManageContent/Message',
            method: 'POST',                      
            dataType:""json"",//服务器返回类型
            contentType:""application/x-www-form-urlencoded"",
            toolbar: '#toolbar',                //工具按钮用哪个容器
            striped: true,                      //是否显示行间隔色
            pagination: true,                   //是否显示分页（*）
            cache: false,     
            sortOrder: ""asc"",     
            sidePagination: ""server"",           //分页方式：client客户端分页，server服务端分页（*）
            pageNumber:1,     ");
            WriteLiteral(@"                  //初始化加载第一页，默认第一页
            pageSize: 10,                       //每页的记录行数（*）
            pageList: [10, 25, 50, 100],        //可供选择的每页的行数（*）
            search:true,
            clickToSelect:true,
            queryParams : function (params) {
                    //这里的键的名字和控制器的变量名必须一直，这边改动，控制器也需要改成一样的
                    var temp = {   
                        rows: params.limit,                         //页面大小
                        page: (params.offset / params.limit) + 1,   //页码
                        sort: params.sort,      //排序列名  
                        sortOrder: params.order,//排位命令（desc，asc） 
                        search:params.search
                    };
                    return temp;
                },
            columns: [
               {
               checkbox:true
             },{
                field: 'id',
                title: '编号'
            }, {
                field: 'name',
                title: '姓名'
            }, {
             ");
            WriteLiteral(@"   field: 'phone',
                title: '电话'
            }
            , {
                field: 'email',
                title: '电子邮箱'
            }
            , {
                field: 'infos',
                title: '信息'
            }
            , {
                field: 'createDate',
                title: '创建日期'
            }
            ],
            onLoadSuccess:function(){
                console.info(""数据加载成功"");
            },
            onLoadError:function(){
                console.info(""加载数据失败"");
            }
        });
    $(""#delete"").click(function(){
        var ids=$.map($table.bootstrapTable('getSelections'),function(row){return row.id});
        if (ids.length != 1 ) {
            alert(""请选择一行删除!"");
            return;
        }
        $.ajax({
            url:'/ManageContent/DeleteMessage?id='+ids,
            method:'POST',
            async:false,
            cache:false,
            success:function(){
                location.reload(true)");
            WriteLiteral(";\r\n            }\r\n        });\r\n    });\r\n</script>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591