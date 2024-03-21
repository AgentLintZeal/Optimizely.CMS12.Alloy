using CMS12.Alloy.Models.Pages;
using CMS12.Alloy.Models.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace CMS12.Alloy.Controllers;

public class SearchPageController : PageControllerBase<SearchPage>
{
    public ViewResult Index(SearchPage currentPage, string q)
    {
        var model = new SearchContentModel(currentPage)
        {
            Hits = Enumerable.Empty<SearchContentModel.SearchHit>(),
            NumberOfHits = 0,
            SearchServiceDisabled = true,
            SearchedQuery = q
        };

        return View(model);
    }
}
