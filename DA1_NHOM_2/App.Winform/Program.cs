using App.Services.Services;
using App.Winform.UI;
using Microsoft.Extensions.DependencyInjection;

namespace App.Winform
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<Form_DangNhap>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Đăng ký các dịch vụ và form
            services.AddTransient<Form_DangNhap>();

            // Đăng ký các dịch vụ khác
            services.AddTransient<SanPham_Services>();
            services.AddTransient<BanHang_Services>();
        }
    }
}