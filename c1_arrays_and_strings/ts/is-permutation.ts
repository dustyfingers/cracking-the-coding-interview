// 1.2 implement an algorithm that, when given two strings, will determine if one is a permutation of the other

const isPermutation = (firstStr: string, secondStr: string) => {
  const firstStrArray = [...firstStr].sort((a, b) => a.localeCompare(b));
  const secondStrArray = [...secondStr].sort((a, b) => a.localeCompare(b));
  const isSame =
    firstStrArray.length === secondStr.length &&
    firstStrArray.every((element, idx) => element === secondStrArray[idx]);
  return isSame;
};

// test cases
console.log(isPermutation("abc", "cba")); // should be true
console.log(isPermutation("abc", "cbaz")); // should be false
