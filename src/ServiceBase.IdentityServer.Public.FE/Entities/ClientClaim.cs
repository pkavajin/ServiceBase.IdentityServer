﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;

namespace ServiceBase.IdentityServer.Public.EntityFramework.Entities
{
    public class ClientClaim
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public Client Client { get; set; }
    }
}