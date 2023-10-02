
const request = require('supertest');
const app = require('../index');  
const { Contact } = require('../models/contacts');

// Clear database before running tests
beforeEach(async () => {
    await Contact.deleteMany();
});

test('Should create a new contact', async () => {
    const response = await request(app)
        .post('/api/v1/contacts')
        .send({
            name: 'Test Name',
            phoneNumber: '0123456789',
            email: 'test@example.com'
        })
        .expect(201);

    const contact = await Contact.findById(response.body._id);
    expect(contact).not.toBeNull();
    expect(contact.name).toEqual('Test Name');
});



// Clear database after all tests have run
afterAll(async () => {
    await Contact.deleteMany();
    await mongoose.connection.close(); // close the connection to the database
});
