using BookTalk.Data;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

public class NavigationService
{
    private Context _context;

    private IHttpContextAccessor _accesor;

    private bool didAcceptCookies = false;
    


    public NavigationService(Context context, IHttpContextAccessor accesor)
    {
        _context = context;
        _accesor = accesor;

    }

    public List<Content> GetMenu()
    {
        return _context.Content.Where(page => page.IsInMenu.Equals(true) && page.IsPublished.Equals(true)).OrderBy(x => x.MenuOrder).ToList();
    }

    public bool NewUser()
    {
        if (!didAcceptCookies)
        { 
            if (_accesor.HttpContext.Request.Cookies.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }

        return false;

    }


    public void DidAcceptCookie(bool value)
    {
        didAcceptCookies = value; 

        _accesor.HttpContext.Response.Cookies.Append("bt_dac", "true");
            
    }

}