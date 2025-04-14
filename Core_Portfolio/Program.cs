using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<WriterUser, WriterRole>().AddEntityFrameworkStores<Context>();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddMvc(config => //MVC yapılandırmasını başlatır İçindeki config parametresi, MVC ayarlarını yapılandırmanı sağlar (örn. filtre ekleme).
{
	var policy = new AuthorizationPolicyBuilder() //Yeni bir yetkilendirme politikası oluşturmak için kullanılır.
	.RequireAuthenticatedUser() //politikanın, sadece kimliği doğrulanmış (authenticated) kullanıcıların erişimine izin vermesini şart koşar.
	.Build(); //Politika nesnesini inşa eder.
	config.Filters.Add(new AuthorizeFilter(policy)); //Tanımlanan bu politikayı bir global yetkilendirme filtresi olarak ekler.
}); //Böylece tüm controller ve action'larda [Authorize] yazmadan otomatik olarak kimlik doğrulama zorunlu hale gelir.
	//builder.Services.AddMvc();
	//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	//	.AddCookie(x =>
	//	{
	//		x.LoginPath = "/AdminLogin/Index/";
	//	});
builder.Services.ConfigureApplicationCookie(options => //ASP.NET Core uygulamasında çerez (cookie) tabanlı kimlik doğrulama sisteminin davranışlarını yapılandırmak
{
	options.Cookie.HttpOnly = true; //Cookie sadece sunucu tarafından okunabilir (JS erişemez). Güvenlik sağlar.
	options.ExpireTimeSpan = TimeSpan.FromMinutes(100); //Cookie’nin süresini belirler (örn. 10 dakika sonra oturumu sonlandır).
	options.AccessDeniedPath = "/ErrorPage/Index/"; //	Kullanıcının yetkisi olmayan bir sayfaya erişmeye çalıştığında yönlendirileceği hata sayfası.
	options.LoginPath = "/Writer/Login/Index/";//Giriş yapılmadan korumalı sayfaya erişilirse yönlendirilecek login URL'si.
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication(); /*kimlik doğrulama  Kullanıcının kimliğini doğrular ancak bu kullanıcıya bir işlem yapma izni vermez.;giriş yapma vs*/
app.UseRouting();

app.UseAuthorization(); /*yetkilendirme  Kullanıcı giriş yapmış olsa bile, sadece "Admin" rolüne sahip kullanıcıların belirli bir sayfaya erişmesini sağlar.*/

app.MapControllerRoute(
	name: "areas",
	pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}"
);

//  Sonra DEFAULT rotayı tanımlıyoruz
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();

