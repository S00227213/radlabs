const express = require('express');
const router = express.Router();
const Category = require('./category');

// GET all categories
router.get('/', async (req, res) => {
    try {
        const categories = await Category.find();
        res.json(categories);
    } catch (err) {
        res.json({ message: err.message });
    }
});

module.exports = router;
