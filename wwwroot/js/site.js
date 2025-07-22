window.getCaliforniaTime = () => {
    return new Date().toLocaleString("en-US", { timeZone: "America/Los_Angeles" });
};