const mongoose = require('mongoose');
const Joi = require('joi');

// Joi validation 
const titleSchema = Joi.string().min(3).max(255).required();
const descriptionSchema = Joi.string().max(1000);
const dateSchema = Joi.date().greater('now');
const prioritySchema = Joi.string().valid('Low', 'Medium', 'High');

const taskSchema = new mongoose.Schema({
    title: {
        type: String,
        required: true,
        validate: {
            validator: title => titleSchema.validate(title).error == null,
            message: 'Title should be between 3 and 255 characters long.'
        }
    },
    description: {
        type: String,
        validate: {
            validator: desc => descriptionSchema.validate(desc).error == null,
            message: 'Description should be a maximum of 1000 characters.'
        }
    },
    dueDate: {
        type: Date,
        validate: {
            validator: date => dateSchema.validate(date).error == null,
            message: 'Due date should be in the future.'
        }
    },
    priority: {
        type: String,
        validate: {
            validator: priority => prioritySchema.validate(priority).error == null,
            message: 'Priority should be one of [Low, Medium, High].'
        }
    },
    status: String,
    
    category: {
        type: mongoose.Schema.Types.ObjectId,
        ref: 'Category', 
        required: false
    }
});

module.exports = mongoose.model('Task', taskSchema);
