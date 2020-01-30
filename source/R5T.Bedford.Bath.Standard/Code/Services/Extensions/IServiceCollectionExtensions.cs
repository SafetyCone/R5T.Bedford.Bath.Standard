using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bath.Standard;
using R5T.Dacia;


namespace R5T.Bedford.Bath.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the binary-based <see cref="IFileEqualityComparer"/> service.
        /// </summary>
        public static IServiceCollection AddBinaryFileEqualityComparer(this IServiceCollection services)
        {
            services.AddBathBinaryFileEqualityComparer(services.AddHumanOutputAction());

            return services;
        }

        /// <summary>
        /// Adds the binary-based <see cref="IFileEqualityComparer"/> service.
        /// </summary>
        public static ServiceAction<IFileEqualityComparer> AddBinaryFileEqualityComparerAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IFileEqualityComparer>(() => services.AddBinaryFileEqualityComparer());
            return serviceAction;
        }

        /// <summary>
        /// Adds the text-based <see cref="IFileEqualityComparer"/> service.
        /// </summary>
        public static IServiceCollection AddTextFileEqualityComparer(this IServiceCollection services)
        {
            services.AddBathTextFileEqualityComparer(services.AddHumanOutputAction());

            return services;
        }

        /// <summary>
        /// Adds the text-based <see cref="IFileEqualityComparer"/> service.
        /// </summary>
        public static ServiceAction<IFileEqualityComparer> AddTextFileEqualityComparerAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IFileEqualityComparer>(() => services.AddTextFileEqualityComparer());
            return serviceAction;
        }
    }
}
