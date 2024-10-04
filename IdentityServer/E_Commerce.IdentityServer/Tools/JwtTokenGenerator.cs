﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace E_Commerce.IdentityServer.Tools
{
    public class JwtTokenGenerator
    {
        public static TokenResponseViewModel GenerateToken(GetCheckAppUserViewModel model)
        {
            var claims = new List<Claim>();

            if (!string.IsNullOrWhiteSpace(model.Role))claims.Add(new Claim(ClaimTypes.Role, model.Role));
            claims.Add(new Claim(ClaimTypes.NameIdentifier,model.Id));

            if(!string.IsNullOrWhiteSpace(model.UserName)) claims.Add(new Claim("UserName",model.UserName));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefault.Key));

            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var expireDate = DateTime.Now.AddDays(JwtTokenDefault.Expire);

            JwtSecurityToken token = new JwtSecurityToken(issuer: JwtTokenDefault.ValidIssuer,
                audience:JwtTokenDefault.ValidAudience,claims: claims,notBefore:DateTime.UtcNow,
                expires:expireDate, signingCredentials: signingCredentials);

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            return new TokenResponseViewModel(tokenHandler.WriteToken(token), expireDate);

        }
    }
}