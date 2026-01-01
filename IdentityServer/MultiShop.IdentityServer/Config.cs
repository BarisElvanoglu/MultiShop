// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.




using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;

namespace MultiShop.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
            new ApiResource("ResourceCatalog"){Scopes={"CatalogFullPermission"}},
            new ApiResource("ResourceDiscount"){Scopes={"DiscountFullPermission"}},
            new ApiResource("ResourceOrder"){Scopes={"OrderFullPermission"}}

        };

        public static IEnumerable<IdentityResource> IdentityResources => new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Email(),
            new IdentityResources.Profile()

        };

        public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]
        {
            new ApiScope("CatalogFullPermission, Full authority for catalog operation"),
            new ApiScope("CatalogFullPermission, Reading authory for catalog operations"),
            new ApiScope("DiscountFullPermission, Full authority for discount operation"),
            new ApiScope("OrderFullPermission, Full authority for order operation")
        };

        new public static IEnumerable<Client> Clients => new Client[]
        {
            new Client
            {
                ClientId="MultiShopVisitorId",
                ClientName="Multi Shop visitor user",
                AllowedGrantTypes=GrantTypes.ClientCredentials,
                ClientSecrets={ new Secret("secret".Sha256()) },
                AllowedScopes={
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    IdentityServerConstants.StandardScopes.Email,
                    "CatalogFullPermission",
                    "DiscountFullPermission",
                    "OrderFullPermission"
                }

            }
        };

    }
}