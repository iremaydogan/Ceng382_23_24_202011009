using Microsoft.AspNetCore.Mvc;
using MyRazorApp.Data;  // Eğer AppDbContext bu ad alanı altındaysa

public class HomeController : Controller
{
    private readonly MyRazorApp.Data.Ceng382Context _dbContext;  // Alan adını düzeltin

    public HomeController(MyRazorApp.Data.Ceng382Context dbContext)
    {
        _dbContext = dbContext;  // Parametre türü ve alan türü aynı olmalı
    }
}
