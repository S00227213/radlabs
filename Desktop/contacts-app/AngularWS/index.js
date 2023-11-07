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

const contacts = [
  
    { name: 'John', number: '1234567890', email: 'john@email.com' },
    
];

app.get('/api/v1/test', (req, res) => {
    res.json({ message: 'Hello from Express with /api/v1 prefix!', apiKey: req.header('X-API-key') });
});


app.get('/api/v1/contacts', (req, res) => {
    res.json(contacts);
});

app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});

app.use((req, res, next) => {
    const apiKey = req.headers['x-api-key'];
    if (apiKey !== 'Jack Monaghan') {
        return res.status(403).json({ message: "Forbidden: Invalid API key." });
    }
    next();
});
