namespace EvaluacionFinal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Cargar cadenas de conexión desde appsettings.json
            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            // Registrar DatabaseSettings para usarlo en cualquier parte del proyecto
            builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("ConnectionStrings"));

            // Registrar servicios de controladores
            builder.Services.AddControllersWithViews();

            // Habilitar sesiones
            builder.Services.AddSession();

            // Registrar servicios de autorización
            builder.Services.AddAuthorization();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // Habilitar el middleware de sesión
            app.UseSession();  // Esto es necesario para poder utilizar la sesión

            // Habilitar autorización
            app.UseAuthorization();

            // Configurar rutas para los controladores
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
