import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { AppTokenService } from "../core/services/token.service";
import { SignInModel } from "../models/signIn.model";
import { TokenModel } from "../models/token.model";

@Injectable({ providedIn: "root" })
export class AppAuthService {
    constructor(
        private readonly http: HttpClient,
        private readonly router: Router,
        private readonly appTokenService: AppTokenService) { }

    signIn(signInModel: SignInModel): void {
        this.http
            .post<TokenModel>(`Auth`, signInModel)
            .subscribe((tokenModel) => {
                if (!tokenModel || !tokenModel.token) { return; }
                this.appTokenService.set(tokenModel.token);
                this.router.navigate(["/main/home"]);
            });
    }

    signOut() {
        this.appTokenService.clear();
        this.router.navigate(["/login"]);
    }
}
