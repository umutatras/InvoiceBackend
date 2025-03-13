import { Component } from '@angular/core';
import { AuthService } from '../auth.service';
import { AuthLoginCommand } from '../models/auth-login-command.model'; // AuthLoginCommand'ı içe aktarıyoruz

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  email: string = '';
  password: string = '';
  errorMessage: string = '';

  constructor(private authService: AuthService) {}

  onSubmit(): void {
    const authLoginCommand: AuthLoginCommand = {
      email: this.email,
      password: this.password,
    };

    this.authService.login(authLoginCommand).subscribe({
      next: (response) => {
        console.log('Login successful', response);
        this.authService.saveToken(response); // Token'ı kaydediyoruz
      },
      error: (error) => {
        console.error('Login failed', error);
        this.errorMessage = 'Invalid credentials, please try again!';
      }
    });
  }
}
