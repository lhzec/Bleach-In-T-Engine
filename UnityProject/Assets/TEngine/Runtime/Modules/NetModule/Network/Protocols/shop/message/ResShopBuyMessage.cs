using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 购买道具返回，成功的话，客户端自己刷新商店 message
 */
public class ResShopBuyMessage : Message 
{
	//商店类型(1:浦原商店, 2:竞技商店)
	int _type;	
	//index 大于 0的时候表示操作成功，为序号。index 小于 0表示失败
	int _index;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//商店类型(1:浦原商店, 2:竞技商店)
		SerializeUtils.WriteInt(stream, _type);
		//index 大于 0的时候表示操作成功，为序号。index 小于 0表示失败
		SerializeUtils.WriteInt(stream, _index);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//商店类型(1:浦原商店, 2:竞技商店)
		_type = SerializeUtils.ReadInt(stream);
		//index 大于 0的时候表示操作成功，为序号。index 小于 0表示失败
		_index = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 商店类型(1:浦原商店, 2:竞技商店)
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * index 大于 0的时候表示操作成功，为序号。index 小于 0表示失败
	 */
	public int Index
	{
		set { _index = value; }
	    get { return _index; }
	}
	
	
	public override int GetId() 
	{
		return 104102;
	}
}