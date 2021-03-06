#pragma checksum "D:\Cosmetology\Views\Account\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ad04890834320f2710cada86dcd7baa4eddb151"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Show), @"mvc.1.0.view", @"/Views/Account/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Show.cshtml", typeof(AspNetCore.Views_Account_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad04890834320f2710cada86dcd7baa4eddb151", @"/Views/Account/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecef6319a6eba9cde12fccd72687063ce2c1f341", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Cosmetology\Views\Account\Show.cshtml"
  
   Layout="/Views/ManageContent/_Layout.cshtml";
   ViewBag.Title = "显示用户列表";

#line default
#line hidden
            BeginContext(83, 3221, true);
            WriteLiteral(@"<div class=""container"">
    <br/>
    <br/>
        <div class=""col-sm-1 col-md-1 col-lg-1""></div>
         <div class=""col-sm-10 col-md-10 col-lg-10"">
             <div id=""toolbar"">
                <button id=""delete"" class=""btn btn-danger"">删除</button>
             </div>
             <table id=""listtable"" data-click-to-select=""true""></table>
         </div>
        <div class=""col-sm-1 col-md-1 col-lg-1""></div>
    </div>
    <div><div class=""col-sm-10 col-md-10 col-lg-10 col-sm-offset-1 col-md-offset-1 col-lg-offset-1""><label>右上角搜索框根据用户名查找账号</label></div></div>
<script>
       $table=$(""#listtable"");
		 $table.bootstrapTable({
            url:'/ManageContent/GetInfos',
            method:'POST',                  //请求方式（*）
            dataType:""json"",
            contentType:""application/x-www-form-urlencoded"",
            striped:true,                      //是否显示行间隔色
            pagination:true,                   //是否显示分页（*）
            sortable:true,                     //是否启用排序
            sortOrder:""as");
            WriteLiteral(@"c"",     
            clickToSelect:true,
            search:true,
            toolbar:'#toolbar',//工具栏按钮
            sidePagination:""server"",           //分页方式：client客户端分页，server服务端分页（*）
            queryParamsType:'limit',
            pageNumber:1,                       //初始化加载第一页，默认第一页
            pageSize: 10,                       //每页的记录行数（*）
            pageList: [10, 25, 50, 100],        //可供选择的每页的行数（*）
            clickToSelect:true,
            queryParams : function (params) {
                    //这里的键的名字和控制器的变量名必须一直，这边改动，控制器也需要改成一样的
                    var temp = {   
                        rows: params.limit,                         //页面大小
                        page: (params.offset / params.limit) + 1,   //页码
                        sort: params.sort,      //排序列名  
                        sortOrder: params.order,
                        search:params.search
                    };
                    return temp;
                },
            columns: [   {
              checkbox:true
         ");
            WriteLiteral(@"   },{
                field: 'id',
                title: '编号'
            }, {
                field: 'userName',
                title: '用户名',
                formatter:function(value,row,index,field){
                    if(value.length>8){
                    var urls=value.slice(22,);
                    return ""<img src='""+urls+""' style='width:60px;height:60px;' alt='image'/>"";
                    }else{
                        return value;
                    }
                }
            }],
            onLoadSuccess:function(){
                console.info(""加载成功"");
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
            url:'/Account/Delete?id='+ids,
            method:'POST',
            asy");
            WriteLiteral("nc:false,\n            cache:false,\n            success:function(){\n                location.reload(true);\n            }\n        });\n    });\n</script>");
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
