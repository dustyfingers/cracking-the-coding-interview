// 1.3 implement an algorithm that when given string will replace
// space characters with '%20'

const URLify = (givenStr: string) => {
  return givenStr.split(" ").join("%20");
};

// test case
