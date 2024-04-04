// 1.1 implement an algorithm to determine if a string has all unique
// characters.

const isUnique = (givenStr: string) => {
  // will contain a map of each character in the string to the number of times it shows up in the string
  const freqHash = {};

  for (let i = 0; i < givenStr.length; i++) {
    const char = givenStr[i];
    // check if a key of this value exists
    if (freqHash[char] === undefined) {
      freqHash[char] = 0;
    } else freqHash[char]++;
  }

  // iterate over entire hash map and if every value is 1 - return true, else false
  for (const [key, value] of Object.entries(freqHash)) {
    if (value !== 1) return false;
  }
  return true;
};

// test cases
