import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { AddUserModel } from "../models/user/add.user.model";
import { UpdateUserModel } from "../models/user/update.user.model";
import { UserModel } from "../models/user/user.model";

@Injectable({ providedIn: "root" })
export class AppUserService {
    constructor(private readonly http: HttpClient) { }

    add(addUserModel: AddUserModel) {
        return this.http.post<number>(`Users`, addUserModel);
    }

    delete(id: number) {
        return this.http.delete(`Users/${id}`);
    }

    list() {
        return this.http.get<UserModel[]>(`Users`);
    }

    select(id: number) {
        return this.http.get<UserModel>(`Users/${id}`);
    }

    update(updateUserModel: UpdateUserModel) {
        return this.http.put(`Users/${updateUserModel.id}`, updateUserModel);
    }
}
