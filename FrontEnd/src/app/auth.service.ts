import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { AuthLoginCommand } from '../app/models/auth-login-command.model'; // Giriş modelini içe aktarıyoruz
import { AuthResponse } from '../app/models/auth-response.model'; // Yanıt modelini içe aktarıyoruz

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private apiUrl = 'https://localhost:7289/api/auth/login';  // API URL

  constructor(private http: HttpClient) {}

  // Giriş işlemi
  login(authLoginCommand: AuthLoginCommand): Observable<AuthResponse> {
    return this.http.post<AuthResponse>(this.apiUrl, authLoginCommand);
  }

  // Token'ı ve refresh token'ı kaydediyoruz
  saveToken(authResponse: AuthResponse): void {
    localStorage.setItem('authToken', authResponse.token);
    localStorage.setItem('refreshToken', authResponse.refreshToken);
    localStorage.setItem('expiresAt', authResponse.expiresAt);
  }

  // Token'ı almak için
  getToken(): string | null {
    return localStorage.getItem('authToken');
  }

  // Token'ın geçerliliğini kontrol et
  isTokenExpired(): boolean {
    const expiresAt = localStorage.getItem('expiresAt');
    if (!expiresAt) return true;
    return new Date(expiresAt).getTime() < new Date().getTime();
  }

  // Refresh token ile yeni token almak
  refreshToken(): Observable<AuthResponse> {
    const refreshToken = localStorage.getItem('refreshToken');
    if (!refreshToken) {
      throw new Error('Refresh token not found');
    }
    return this.http.post<AuthResponse>(`${this.apiUrl}/refresh`, { refreshToken });
  }
}
