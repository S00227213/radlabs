const express = require('express');
const mongoose = require('mongoose');
const router = express.Router();
const Task = require('../models/task');
const Joi = require('joi');

// Middleware to check if a task exists in the database by its ID
async function getTask(req, res, next) {
    if (!mongoose.Types.ObjectId.isValid(req.params.id)) {
        return res.json({ message: 'Invalid task ID format.' });
    }

    try {
        const task = await Task.findById(req.params.id);
        if (!task) {
            return res.json({ message: 'Task not found.' });
        }
        res.task = task;
        next();
    } catch (err) {
        res.json({ message: 'Server error. Please try again later.' });
    }
}

// GET endpoint to retrieve all tasks
router.get('/', async (req, res) => {
    try {
        const tasks = await Task.find(); 
        res.json(tasks);
    } catch (err) {
        res.json({ message: 'Failed to retrieve tasks. Please try again later.' });
    }
});


// POST endpoint to create a new task
router.post('/', async (req, res) => {
    const task = new Task({
        title: req.body.title,
        description: req.body.description,
        dueDate: req.body.dueDate,
        priority: req.body.priority,
        status: req.body.status,
     
    });

    try {
        const newTask = await task.save();
        res.json(newTask);
    } catch (err) {
        res.json({ message: err.message });
    }
});

// GET endpoint to retrieve a single task by its ID
router.get('/:id', getTask, (req, res) => {
    res.json(res.task);
});

// PUT endpoint to update an existing task by its ID
router.put('/:id', getTask, async (req, res) => {
    if (req.body.title) res.task.title = req.body.title;
    if (req.body.description) res.task.description = req.body.description;
    if (req.body.dueDate) res.task.dueDate = req.body.dueDate;
    if (req.body.priority) res.task.priority = req.body.priority;
    if (req.body.status) res.task.status = req.body.status;
    if (req.body.user) res.task.user = req.body.user; 
  
    try {
        const updatedTask = await res.task.save();
        res.json(updatedTask);
    } catch (err) {
        res.json({ message: err.message });
    }
});

// DELETE endpoint to remove a task by its ID
router.delete('/:id', getTask, async (req, res) => {
    try {
        await Task.findByIdAndDelete(req.params.id);
        res.json({ message: 'Task deleted successfully.' });
    } catch (err) {
        res.json({ message: 'Failed to delete task. Please try again later.' });
    }
});


module.exports = router;
