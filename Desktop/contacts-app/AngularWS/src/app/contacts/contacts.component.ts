import { Component, OnInit } from '@angular/core';
import { DummycontactService } from '../dummycontact.service';
import { Contact } from '../contact';

@Component({
    selector: 'app-contacts',
    templateUrl: './contacts.component.html',
    styleUrls: ['./contacts.component.css']
})
export class ContactsComponent implements OnInit {

    contacts: Contact[] = [];
    message: string = '';

    constructor(private contactService: DummycontactService) { }

    ngOnInit(): void {
        this.contactService.getContacts().subscribe({
            next: (value: Contact[]) => this.contacts = value,
            complete: () => console.log('contact service finished')
        });
    }
}
