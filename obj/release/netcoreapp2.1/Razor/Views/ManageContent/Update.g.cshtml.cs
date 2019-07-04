#pragma checksum "D:\Cosmetology\Views\ManageContent\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97572814f34a0daaa5c0effb28fd51dce1b0c507"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageContent_Update), @"mvc.1.0.view", @"/Views/ManageContent/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ManageContent/Update.cshtml", typeof(AspNetCore.Views_ManageContent_Update))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97572814f34a0daaa5c0effb28fd51dce1b0c507", @"/Views/ManageContent/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecef6319a6eba9cde12fccd72687063ce2c1f341", @"/Views/_ViewImports.cshtml")]
    public class Views_ManageContent_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Cosmetology\Views\ManageContent\Update.cshtml"
  
  Layout="/Views/ManageContent/_Layout.cshtml";
  ViewData["Title"]="网站内容修改";

#line default
#line hidden
            BeginContext(83, 3636, true);
            WriteLiteral(@"    <div class=""container"">
        <div class=""col-sm-1 col-md-1 col-lg-1""></div>
         <div class=""col-sm-10 col-md-10 col-lg-10"">
             <div id=""toolbar"">
                <button id=""delete"" class=""btn btn-danger"">删除</button>
             </div>
             <table id=""listtable"" data-click-to-select=""true""></table>
         </div>
        <div class=""col-sm-1 col-md-1 col-lg-1""></div>
    </div>
    <div class=""col-sm-10 col-md-10 col-lg-10 col-sm-offset-1 col-md-offset-1 col-lg-offset-1"">
        <label><strong style=""color:red;"">注：右上角的搜索栏 根据 更新类型  列进行搜索</strong></label>
    </div>
<script>
       $table=$(""#listtable"");
		 $table.bootstrapTable({
            url:'/ManageContent/Updates',
            method:'POST',                  //请求方式（*）
            dataType:""json"",
            contentType:""application/x-www-form-urlencoded"",
            striped:true,                      //是否显示行间隔色
            pagination:true,                   //是否显示分页（*）
            sortable:true,                     //是");
            WriteLiteral(@"否启用排序
            sortOrder:""asc"",     
            clickToSelect:true,
            search:true,
            toolbar:'#toolbar',//工具栏按钮
            sidePagination:""server"",           //分页方式：client客户端分页，server服务端分页（*）
            queryParamsType:'limit',
            pageNumber:1,                       //初始化加载第一页，默认第一页
            pageSize: 10,                       //每页的记录行数（*）
            pageList: [10, 20, 30, 40],        //可供选择的每页的行数（*）
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
            columns: [
           ");
            WriteLiteral(@"    {
                checkbox:true
             },{
                field: 'id',
                title: '编号'
            }, {
                field: 'updateContent',
                title: '更新内容',
                formatter:function(value,row,index,field){
                    if(value.length>22){
                    //var urls=value.slice(22,);
                    return ""<img src='""+value+""' style='width:60px;height:60px;' alt='image'/>"";
                    }else{
                        return value;
                    }
                }
            }, {
                field: 'updateType',
                title: '更新类型'
            }
            , {
                field: 'updateDate',
                title: '更新时间'
            }
            , {
                field: 'updateUserName',
                title: '更新人'
            }
            ],
            onLoadSuccess:function(){
                console.info(""加载成功"");
            },
            onLoadError:function(){
                console.info(""加载数据失败"")");
            WriteLiteral(@";
            }
        });
    $(""#delete"").click(function(){
        var ids=$.map($table.bootstrapTable('getSelections'),function(row){return row.id});
        if (ids.length != 1 ) {
            alert(""请选择一行删除!"");
            return;
        }
        $.ajax({
            url:'/ManageContent/Delete?id='+ids,
            method:'POST',
            cache:false,
            success:function(){
                location.reload(true);
            },
            fail:function(){
                console.log(""failure"");
            }
        });
    });
</script>");
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
