#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    
    #line 2 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using System;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    #line 4 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Dashboard.Resources;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.States;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Storage;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class RecurringJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");










            
            #line 10 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
  
    Layout = new LayoutPage(Strings.RecurringJobsPage_Title);
	List<RecurringJobDto> recurringJobs;
    
    int from, perPage;

    int.TryParse(Query("from"), out from);
    int.TryParse(Query("count"), out perPage);

    Pager pager = null;

	using (var connection = Storage.GetConnection())
	{
	    var storageConnection = connection as JobStorageConnection;
	    if (storageConnection != null)
	    {
	        pager = new Pager(from, perPage, storageConnection.GetRecurringJobCount());
	        recurringJobs = storageConnection.GetRecurringJobs(pager.FromRecord, pager.FromRecord + pager.RecordsPerPage - 1);
	    }
	    else
	    {
            recurringJobs = connection.GetRecurringJobs();
	    }
	}


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h1 class=\"page-header\"" +
">");


            
            #line 38 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                           Write(Strings.RecurringJobsPage_Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n\r\n");


            
            #line 40 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
         if (recurringJobs.Count == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"alert alert-info\">\r\n                ");


            
            #line 43 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
           Write(Strings.RecurringJobsPage_NoJobs);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");


            
            #line 45 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"js-jobs-list\">\r\n                <div class=\"btn-toolbar b" +
"tn-toolbar-top\">\r\n                    <button class=\"js-jobs-list-command btn bt" +
"n-sm btn-primary\"\r\n                            data-url=\"");


            
            #line 51 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                 Write(Url.To("/recurring/trigger"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            data-loading-text=\"");


            
            #line 52 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                          Write(Strings.RecurringJobsPage_Triggering);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            disabled=\"disabled\">\r\n                        <spa" +
"n class=\"glyphicon glyphicon-play-circle\"></span>\r\n                        ");


            
            #line 55 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                   Write(Strings.RecurringJobsPage_TriggerNow);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </button>\r\n\r\n                    <button class=\"js-jobs-lis" +
"t-command btn btn-sm btn-default\"\r\n                            data-url=\"");


            
            #line 59 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                 Write(Url.To("/recurring/disable"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            data-loading-text=\"");


            
            #line 60 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                          Write(Strings.RecurringJobsPage_Disabling);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            disabled=\"disabled\">\r\n                        <spa" +
"n class=\"glyphicon glyphicon-pause\"></span>\r\n                        ");


            
            #line 63 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                   Write(Strings.RecurringJobsPage_Disable);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </button>\r\n\r\n                    <button class=\"js-jobs-lis" +
"t-command btn btn-sm btn-default\"\r\n                            data-url=\"");


            
            #line 67 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                 Write(Url.To("/recurring/enable"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            data-loading-text=\"");


            
            #line 68 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                          Write(Strings.RecurringJobsPage_Enabling);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            disabled=\"disabled\">\r\n                        <spa" +
"n class=\"glyphicon glyphicon-play\"></span>\r\n                        ");


            
            #line 71 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                   Write(Strings.RecurringJobsPage_Enable);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </button>\r\n\r\n                    <button class=\"js-jobs-lis" +
"t-command btn btn-sm btn-default\"\r\n                            data-url=\"");


            
            #line 75 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                 Write(Url.To("/recurring/remove"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            data-loading-text=\"");


            
            #line 76 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                          Write(Strings.Common_Deleting);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            data-confirm=\"");


            
            #line 77 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                     Write(Strings.Common_DeleteConfirm);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            disabled=\"disabled\">\r\n                        <spa" +
"n class=\"glyphicon glyphicon-remove\"></span>\r\n                        ");


            
            #line 80 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                   Write(Strings.Common_Delete);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </button>\r\n\r\n");


            
            #line 83 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                     if (pager != null)
    {

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral(" ");


            
            #line 85 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
              Write(Html.PerPageSelector(pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 86 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral(@"                </div>

                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th class=""min-width"">
                                    <input type=""checkbox"" class=""js-jobs-list-select-all"" />
                                </th>
                                <th class=""min-width"">");


            
            #line 96 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                 Write(Strings.Common_Id);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"min-width\">");


            
            #line 97 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                 Write(Strings.RecurringJobsPage_Table_Cron);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"min-width\">");


            
            #line 98 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                 Write(Strings.RecurringJobsPage_Table_TimeZone);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th>");


            
            #line 99 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                               Write(Strings.Common_Job);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"align-right min-width\">");


            
            #line 100 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                             Write(Strings.RecurringJobsPage_Table_NextExecution);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"align-right min-width\">");


            
            #line 101 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                             Write(Strings.RecurringJobsPage_Table_LastExecution);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"align-right min-width\">");


            
            #line 102 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                             Write(Strings.Common_Created);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            </tr>\r\n                        </thead>\r\n     " +
"                   <tbody>\r\n");


            
            #line 106 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                             foreach (var job in recurringJobs)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <tr class=\"js-jobs-list-row hover\">\r\n            " +
"                        <td>\r\n                                        <input typ" +
"e=\"checkbox\" class=\"js-jobs-list-checkbox\" name=\"jobs[]\" value=\"");


            
            #line 110 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                                             Write(job.Id);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n                                    </td>\r\n                                " +
"    <td class=\"min-width\">");


            
            #line 112 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                     Write(job.Id);

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 113 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                     if (job.Disabled)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <br/>");



WriteLiteral("<span class=\"metric-warning\">(");


            
            #line 115 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                      Write(Strings.RecurringJobsPage_Disabled);

            
            #line default
            #line hidden
WriteLiteral(")</span> \r\n");


            
            #line 116 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d class=\"min-width\">\r\n                                        ");



WriteLiteral("\r\n");


            
            #line 120 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                          
                                            string cronDescription = null;
#if NETFULL
                                            try
                                            {
                                                cronDescription = string.IsNullOrEmpty(job.Cron) ? null : CronExpressionDescriptor.ExpressionDescriptor.GetDescription(job.Cron);
                                            }
                                            catch (FormatException)
                                            {
                                            }
#endif
                                        

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 133 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         if (cronDescription != null)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <code title=\"");


            
            #line 135 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                    Write(cronDescription);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 135 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                      Write(job.Cron);

            
            #line default
            #line hidden
WriteLiteral("</code>\r\n");


            
            #line 136 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <code>");


            
            #line 139 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                             Write(job.Cron);

            
            #line default
            #line hidden
WriteLiteral("</code>\r\n");


            
            #line 140 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d class=\"word-break\">\r\n");


            
            #line 143 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         if (!String.IsNullOrWhiteSpace(job.TimeZoneId))
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <span title=\"");


            
            #line 145 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                    Write(TimeZoneInfo.FindSystemTimeZoneById(job.TimeZoneId).DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\" data-container=\"body\">");


            
            #line 145 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                                                                            Write(job.TimeZoneId);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");


            
            #line 146 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            ");

WriteLiteral(" UTC\r\n");


            
            #line 150 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d class=\"word-break\">\r\n");


            
            #line 153 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         if (job.Job != null)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            ");

WriteLiteral(" ");


            
            #line 155 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                          Write(Html.JobName(job.Job));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 156 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <em>");


            
            #line 159 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                           Write(job.LoadException.InnerException.Message);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 160 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d class=\"align-right min-width\">\r\n");


            
            #line 163 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         if (job.NextExecution != null)
                                        {
                                            
            
            #line default
            #line hidden
            
            #line 165 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                       Write(Html.RelativeTime(job.NextExecution.Value));

            
            #line default
            #line hidden
            
            #line 165 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                       
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <em>");


            
            #line 169 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                           Write(Strings.Common_NotAvailable);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 170 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d class=\"align-right min-width\">\r\n");


            
            #line 173 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         if (job.LastExecution != null)
                                        {
                                            if (!String.IsNullOrEmpty(job.LastJobId))
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <a href=\"");


            
            #line 177 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                    Write(Url.JobDetails(job.LastJobId));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                                    <span class=\"label label-" +
"default label-hover\" style=\"");


            
            #line 178 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                                     Write($"background-color: {JobHistoryRenderer.GetForegroundStateColor(job.LastJobState ?? EnqueuedState.StateName)};");

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                                        ");


            
            #line 179 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                   Write(Html.RelativeTime(job.LastExecution.Value));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                    </span>\r\n                  " +
"                              </a>\r\n");


            
            #line 182 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                            }
                                            else
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <em>\r\n                           " +
"                         ");


            
            #line 186 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                               Write(Strings.RecurringJobsPage_Canceled);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 186 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                   Write(Html.RelativeTime(job.LastExecution.Value));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                </em>\r\n");


            
            #line 188 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                            }
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <em>");


            
            #line 192 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                           Write(Strings.Common_NotAvailable);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 193 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d class=\"align-right min-width\">\r\n");


            
            #line 196 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         if (job.CreatedAt != null)
                                        {
                                            
            
            #line default
            #line hidden
            
            #line 198 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                       Write(Html.RelativeTime(job.CreatedAt.Value));

            
            #line default
            #line hidden
            
            #line 198 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                   
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <em>N/A</em>\r\n");


            
            #line 203 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                </tr>\r" +
"\n");


            
            #line 206 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                             }

            
            #line default
            #line hidden
WriteLiteral("                        </tbody>\r\n                    </table>\r\n                <" +
"/div>\r\n\r\n");


            
            #line 211 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                 if (pager != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral(" ");


            
            #line 213 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                  Write(Html.Paginator(pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 214 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");


            
            #line 216 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>    ");


        }
    }
}
#pragma warning restore 1591
