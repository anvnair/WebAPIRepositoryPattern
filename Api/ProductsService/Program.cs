#region Namespaces
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

#endregion

/// <summary>
/// Web Api for Products
/// </summary>
namespace ProductService
{
    /// <summary>
    ///   <para></para>
    ///   <para></para>
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        /// <summary>Builds the web host.</summary>
        /// <param name="args">The arguments.</param>
        /// <returns></returns>
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
