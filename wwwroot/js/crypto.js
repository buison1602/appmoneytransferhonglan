// JavaScript function to encrypt data using RSA-OAEP
async function NewDecryptData(privateKey,plainText ) {
    var decrypt = new JSEncrypt();
    decrypt.setPrivateKey(privateKey);
    return decrypt.decrypt(plainText);
}
async function NewEncryptData(publicKey, plainText) {
    var encrypt = new JSEncrypt();
    encrypt.setPublicKey(publicKey);
    return encrypt.encrypt(plainText);
}
