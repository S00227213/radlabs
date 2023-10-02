const express = require('express');
const { Contact } = require('../models/contacts');
const router = express.Router();
const mongoose = require('mongoose');

// GET Route to fetch all contacts
router.get('/', async (req, res) => {
    try {
        const contacts = await Contact.find();
        res.json(contacts);
    } catch (error) {
        res.status(500).json({ message: 'Database error: ' + error.message });
    }
});

// GET Specific Contact by ID
router.get('/:id', async (req, res) => {
    if (!mongoose.Types.ObjectId.isValid(req.params.id)) {
        return res.status(400).json({ message: 'Invalid ID format.' });
    }
    
    try {
        const contact = await Contact.findById(req.params.id);
        if (!contact) {
            return res.status(404).json({ message: 'Contact not found.' });
        }
        res.json(contact);
    } catch (error) {
        res.status(500).json({ message: 'Database error: ' + error.message });
    }
});

// POST Route to create a new contact
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

// PUT Route to update a specific contact
router.put('/:id', async (req, res) => {
    if (!mongoose.Types.ObjectId.isValid(req.params.id)) {
        return res.status(400).json({ message: 'Invalid ID format.' });
    }

    const { name, phoneNumber, email } = req.body;
    try {
        const updatedContact = await Contact.findByIdAndUpdate(
            req.params.id, 
            { name, phoneNumber, email }, 
            { new: true }
        );

        if (!updatedContact) {
            return res.status(404).json({ message: 'Contact not found' });
        }

        res.json(updatedContact);
    } catch (error) {
        res.status(500).json({ message: 'Database error: ' + error.message });
    }
});

// DELETE Route to delete a specific contact
router.delete('/:id', async (req, res) => {
    if (!mongoose.Types.ObjectId.isValid(req.params.id)) {
        return res.status(400).json({ message: 'Invalid ID format.' });
    }

    try {
        const deletedContact = await Contact.findByIdAndDelete(req.params.id);

        if (!deletedContact) {
            return res.status(404).json({ message: 'Contact not found' });
        }

        res.json({ message: 'Contact deleted' });
    } catch (error) {
        res.status(500).json({ message: 'Database error: ' + error.message });
    }
});

module.exports = router;
