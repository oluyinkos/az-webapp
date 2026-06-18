
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_app_oludolapo.Pages;

public class DeploymentSlotsModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IConfiguration _configuration;

    public DeploymentSlotsModel(ILogger<IndexModel> logger, IConfiguration configuration)
    {
        _logger = logger;
        this._configuration = configuration;

    }
    public void OnGet()
    {
    }
}
