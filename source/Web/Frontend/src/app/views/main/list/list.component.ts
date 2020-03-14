import { HttpClient } from "@angular/common/http";
import { Component } from "@angular/core";

@Component({ selector: "app-list", templateUrl: "./list.component.html" })
export class AppListComponent {
    list: any;

    constructor(private readonly http: HttpClient) {
        this.http
            .get("https://jsonplaceholder.typicode.com/users")
            .subscribe((list: any) => this.list = list);
    }
}
