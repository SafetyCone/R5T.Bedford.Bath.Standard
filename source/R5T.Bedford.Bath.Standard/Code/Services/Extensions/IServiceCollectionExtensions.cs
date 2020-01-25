using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bath.Standard;


namespace R5T.Bedford.Bath.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the binary-based <see cref="IFileEqualityComparer"/> service.
        /// </summary>
        public static IServiceCollection AddBinaryFileEqualityComparer(this IServiceCollection services)
        {
            services
                .AddSingleton<IFileEqualityComparer, BinaryFileEqualityComparer>()
                .AddHumanOutput()
                ;

            return services;
        }

        /// <summary>
        /// Adds the text-based <see cref="IFileEqualityComparer"/> service.
        /// </summary>
        public static IServiceCollection AddTextFileEqualityComparer(this IServiceCollection services)
        {
            services
                .AddSingleton<IFileEqualityComparer, TextFileEqualityComparer>()
                .AddHumanOutput()
                ;

            return services;
        }
    }
}
