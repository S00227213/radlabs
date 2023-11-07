const express = require('express');
const cors = require('cors');

const app = express();
const PORT = 3000;

app.use(cors());

// Middleware for API key validation:
app.use('/api/v1', (req, res, next) => {
    const apiKey = req.header('X-API-key');
    if (apiKey !== 'Jack Monaghan') {
        return res.status(403).json({ message: 'Forbidden: Invalid API key.' });
    }
    next();
});

// Corrected contacts array
const contacts = [
    { name: 'John', phoneNumber: '1234567890', email: 'john@email.com' },
    { name: 'Jane', phoneNumber: '2345678901', email: 'jane@email.com' },
    { name: 'Jim', phoneNumber: '3456789012', email: 'jim@email.com' },
    { name: 'Jill', phoneNumber: '4567890123', email: 'jill@email.com' },
    { name: 'Jack', phoneNumber: '5678901234', email: 'jack@email.com' },
    { name: 'Jenny', phoneNumber: '6789012345', email: 'jenny@email.com' }
];


// Test route
app.get('/api/v1/test', (req, res) => {
    res.json({ message: 'Hello from Express with /api/v1 prefix!', apiKey: req.header('X-API-key') });
});

// Contacts API route
app.get('/api/v1/contacts', (req, res) => {
    res.json(contacts);
});

// Start the server
app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});
