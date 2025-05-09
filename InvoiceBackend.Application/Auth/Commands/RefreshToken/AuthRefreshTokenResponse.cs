﻿namespace InvoiceBackend.Application.Auth.RefreshToken;

public sealed class AuthRefreshTokenResponse
{
    public string Token { get; set; }
    public DateTime ExpiresAt { get; set; }
    public AuthRefreshTokenResponse()
    {

    }
    public AuthRefreshTokenResponse(string token, DateTime expiresAt)
    {
        Token = token;
        ExpiresAt = expiresAt;
    }
}
