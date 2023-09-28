const express = require('express');
const { Contact } = require('../models/contacts');
const router = express.Router();

// Middleware to parse JSON requests
router.use(express.json());

// GET Route
router.get('/', async (req, res) => {
    try {
        let contacts;
        let retries = 3; // Number of retries
        while (retries > 0) {
            contacts = await Contact.find();
            if (contacts.length > 0) {
                break;
            }
            retries--;
        }
        res.json(contacts);
    } catch (error) {
        res.status(500).json('Database error: ' + error);
    }
});

// POST Route
router.post('/', async (req, res) => {
    const { name, phoneNumber, email } = req.body;
    const newContact = new Contact({ name, phoneNumber, email });
    try {
        await newContact.save();
        res.status(201).json(newContact);
    } catch (error) {
        res.status(500).json({ message: 'Database error: ' + error.message });
    }
});

module.exports = router;
