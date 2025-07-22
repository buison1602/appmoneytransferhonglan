async function AESencryptData(plainText, keyBase64, ivBase64) {
    const encoder = new TextEncoder();
    const data = encoder.encode(plainText);

    const key = await window.crypto.subtle.importKey(
        'raw',
        AESbase64ToArrayBuffer(keyBase64),
        { name: 'AES-CBC' },
        false,
        ['encrypt']
    );

    const iv = AESbase64ToArrayBuffer(ivBase64);

    const encrypted = await window.crypto.subtle.encrypt(
        { name: 'AES-CBC', iv: iv },
        key,
        data
    );

    return AESarrayBufferToBase64(encrypted);
}

function AESbase64ToArrayBuffer(base64) {
    const binaryString = atob(base64);
    const len = binaryString.length;
    const bytes = new Uint8Array(len);
    for (let i = 0; i < len; i++) {
        bytes[i] = binaryString.charCodeAt(i);
    }
    return bytes.buffer;
}

function AESarrayBufferToBase64(buffer) {
    const bytes = new Uint8Array(buffer);
    let binary = '';
    for (let i = 0; i < bytes.byteLength; i++) {
        binary += String.fromCharCode(bytes[i]);
    }
    return btoa(binary);
}