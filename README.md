# GIDsいれるやつ
  文責: Yoshida

## 概要
- Githubの[MemoInserter](https://github.com/y-kisse/MemoInserter20170511)
- データ構造はMemosDatumを見れば良い
- 手動で記録したGIDs・充電データメモをインサートするもの
- インサート先はMEMOSテーブルとなっている

## 使い方
- 記録したメモからExcelファイルを作成し、D&Dでインサートを行う
- テンプレートファイル(`Format.xlsx`)に則って記入を行えば良い
- 実際のデータや記入例に疑問がある場合はMEMOSテーブルを参照すること

## 注記
- 電費リセット(ELECTRICITY_EXPENSE_RESET)について
  - 「満タン法」によって電費を計算する手法があり、過去のメモではそのリセット有無を記入していたが、現在はTripごとにリセットしているので、(備考の欄に記入がない等の理由がない限り)1を立てる
- SERIAL_NUMBER列について
  - 主キーを{日付, 往復路}にしていたが、2往復した場合等に重複するので追加したもの
  - 基本的に0で良い


