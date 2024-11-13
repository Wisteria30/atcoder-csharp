# AtCoder C#環境

Scala環境は[こちら](https://github.com/Wisteria30/atcoder-scala)

## Setup

```bash
pip install online-judge-tools
npm install -g atcoder-cli
# ログイン
acc login
oj login https://atcoder.jp/
# config
acc config default-task-choice all
acc config default-test-dirname-format test
a=`acc config-dir`
cp -r ./cs $a/
acc config default-template cs
```

## Usage
```sh
# download
acc new abc379
cd abc379/a
# test
npm run test
# submit
npm run submit
```

## Requirements

- dotnet8
- atcoder-cli
- online-judge-tools

## References

- [AtCoder を C# で戦う環境を整える（.NET Core）](https://oita.oika.me/2020/05/10/at-coder-csharp/)
- [atcoder初心者こそ環境構築しよう！(atcoder-cli,online-judge-toolsのインストール、使い方）](https://qiita.com/Adaachill/items/3d4ddad56c5c2cc372cd)
- [atcoder-cli チュートリアル](http://tatamo.81.la/blog/2018/12/07/atcoder-cli-tutorial/)
- [Getting Started for oj command(日本語)](https://github.com/online-judge-tools/oj/blob/master/docs/getting-started.ja.md)
