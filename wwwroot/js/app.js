// App-specific JavaScript functions

// Download file from stream
window.downloadFileFromStream = async (fileName, contentStreamReference) => {
    const arrayBuffer = await contentStreamReference.arrayBuffer();
    const blob = new Blob([arrayBuffer]);
    const url = URL.createObjectURL(blob);
    const anchorElement = document.createElement('a');
    anchorElement.href = url;
    anchorElement.download = fileName ?? '';
    anchorElement.click();
    anchorElement.remove();
    URL.revokeObjectURL(url);
};

// Get browser dimensions
window.getDimensions = () => {
    return {
        width: window.innerWidth,
        height: window.innerHeight,
        heightBody: window.innerHeight - 100
    };
};

// Get IP address (placeholder - you may need to implement this based on your needs)
window.GetAddress = async () => {
    try {
        // This is a placeholder - you may need to implement actual IP detection
        return "127.0.0.1";
    } catch (error) {
        console.error("Error getting IP address:", error);
        return "";
    }
};

// Open URL in new window/tab
window.openUrl = (url, target) => {
    window.open(url, target || '_blank');
};

// Initialize floating label inputs
window.initializeFloatingLabels = () => {
    const inputs = document.querySelectorAll('.did-floating-input, .did-floating-select');
    inputs.forEach(input => {
        // Remove any existing event listeners to prevent duplicates
        input.removeEventListener('focus', handleFocus);
        input.removeEventListener('blur', handleBlur);
        input.removeEventListener('input', handleInput);
        input.removeEventListener('change', handleChange);

        // Check if input has value on load
        updateLabelState(input);

        // Add event listeners
        input.addEventListener('focus', handleFocus);
        input.addEventListener('blur', handleBlur);
        input.addEventListener('input', handleInput);
        input.addEventListener('change', handleChange);
    });
};

// Event handler functions
function handleFocus() {
    this.parentElement.classList.add('focused');
}

function handleBlur() {
    this.parentElement.classList.remove('focused');
    updateLabelState(this);
}

function handleInput() {
    updateLabelState(this);
}

function handleChange() {
    updateLabelState(this);
}

function updateLabelState(input) {
    const hasValue = input.value && input.value.trim() !== '' && input.value !== '0';
    if (hasValue) {
        input.classList.add('has-value');
    } else {
        input.classList.remove('has-value');
    }
}

// Initialize any required scripts after page load
window.addEventListener('DOMContentLoaded', function() {
    // Initialize floating labels
    initializeFloatingLabels();
    console.log('App initialized');
});

// Re-initialize floating labels after Blazor updates
window.addEventListener('blazor:updated', function() {
    initializeFloatingLabels();
});
