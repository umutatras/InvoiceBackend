﻿namespace InvoiceBackend.Application.Models.Identity;

public class IdentityRefreshTokenRequest
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
    public IdentityRefreshTokenRequest()
    {

    }
    public IdentityRefreshTokenRequest(string accessToken, string refreshToken)
    {
        AccessToken = accessToken;
        RefreshToken = refreshToken;
    }

}
