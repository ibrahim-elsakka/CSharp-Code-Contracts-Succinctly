using CodeContractsDemoProject;
// <copyright file="ERPWarehouseIntegrationFactory.cs">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;

namespace CodeContractsDemoProject
{
    /// <summary>A factory for CodeContractsDemoProject.ERPWarehouseIntegration instances</summary>
    public static partial class ERPWarehouseIntegrationFactory
    {
        /// <summary>A factory for CodeContractsDemoProject.ERPWarehouseIntegration instances</summary>
        [PexFactoryMethod(typeof(ERPWarehouseIntegration))]
        public static ERPWarehouseIntegration Create()
        {
            ERPWarehouseIntegration eRPWarehouseIntegration = new ERPWarehouseIntegration();
            return eRPWarehouseIntegration;

            // TODO: Edit factory method of ERPWarehouseIntegration
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
