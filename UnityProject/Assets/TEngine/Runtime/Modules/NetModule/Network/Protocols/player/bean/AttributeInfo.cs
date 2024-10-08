using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 属性信息
 */
public class AttributeInfo : IMessageSerialize 
{
	//角色id
	int _character;	
	//生命
	int _hp;	
	//灵力
	int _mp;	
	//攻击
	int _atk;	
	//防御
	int _def;	
	//耐力
	int _sta;	
	//暴击
	int _crit;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _character);
		//生命
		SerializeUtils.WriteInt(stream, _hp);
		//灵力
		SerializeUtils.WriteInt(stream, _mp);
		//攻击
		SerializeUtils.WriteInt(stream, _atk);
		//防御
		SerializeUtils.WriteInt(stream, _def);
		//耐力
		SerializeUtils.WriteInt(stream, _sta);
		//暴击
		SerializeUtils.WriteInt(stream, _crit);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//角色id
		_character = SerializeUtils.ReadInt(stream);
		//生命
		_hp = SerializeUtils.ReadInt(stream);
		//灵力
		_mp = SerializeUtils.ReadInt(stream);
		//攻击
		_atk = SerializeUtils.ReadInt(stream);
		//防御
		_def = SerializeUtils.ReadInt(stream);
		//耐力
		_sta = SerializeUtils.ReadInt(stream);
		//暴击
		_crit = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色id
	 */
	public int Character
	{
		set { _character = value; }
	    get { return _character; }
	}
	
	/**
	 * 生命
	 */
	public int Hp
	{
		set { _hp = value; }
	    get { return _hp; }
	}
	
	/**
	 * 灵力
	 */
	public int Mp
	{
		set { _mp = value; }
	    get { return _mp; }
	}
	
	/**
	 * 攻击
	 */
	public int Atk
	{
		set { _atk = value; }
	    get { return _atk; }
	}
	
	/**
	 * 防御
	 */
	public int Def
	{
		set { _def = value; }
	    get { return _def; }
	}
	
	/**
	 * 耐力
	 */
	public int Sta
	{
		set { _sta = value; }
	    get { return _sta; }
	}
	
	/**
	 * 暴击
	 */
	public int Crit
	{
		set { _crit = value; }
	    get { return _crit; }
	}
	
}