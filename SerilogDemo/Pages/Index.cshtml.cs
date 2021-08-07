using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerilogDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("Application started from Index.");

            try
            {
                for (int i = 0; i < 60; i++)
                {
                    if (i == 58)
                    {
                        throw new Exception("this is our demo exception.");
                    }
                    else
                    {
                        _logger.LogInformation("the value of {iVariable} is : ", i);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "we caught exception");
            }
        }
    }
}
