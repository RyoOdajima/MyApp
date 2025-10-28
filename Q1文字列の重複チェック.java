//htmlで作ってしまおう。
//重複のない文字列を検索するjavaコードを書きなさい。
//GitPushしてからhtmlの問題集にする。

import java.util.HashSet;
public class App {
	public static void main(String[] args){
	//重複チェックを行うためのHashSetを作成
	HashSet<String> set = new HashSet<>();

	//チェックするデータの配列
	String[] data = {"apple", "banana", "orange", "apple" , "grape"};

	//重複チェックの実施
	for(String item : data){
	  // HashSet用に要素を追加
	if (!set.add(item)) {
		//追加できなかった場合は重複
		System.out.println(item + " は重複しています。");
			}
		}
	}
}


